       if (isInCurrentView) {
                return;
            }
            // else, fire navigation on the date to change the view to show it
            if (nextDate) {
                onNavigateDate(nextDate, true);
                ev.preventDefault();
            }
        };
        var onMouseOverDay = function (ev) {
            var dayInfos = getDayInfosInRangeOfDay(day);
            var dayRefs = getRefsFromDayInfos(dayInfos);
            dayRefs.forEach(function (dayRef, index) {
                var _a;
                if (dayRef) {
                    dayRef.classList.add('ms-CalendarDay-hoverStyle');
                    if (!dayInfos[index].isSelected &&
                        dateRangeType === date_time_utilities_1.DateRangeType.Day &&
                        daysToSelectInDayView &&
                        daysToSelectInDayView > 1) {
                        // remove the static classes first to overwrite them
                        dayRef.classList.remove(classNames.bottomLeftCornerDate, classNames.bottomRightCornerDate, classNames.topLeftCornerDate, classNames.topRightCornerDate);
                        var classNamesToAdd = calculateRoundedStyles(classNames, false, false, index > 0, index < dayRefs.length - 1).trim();
                        if (classNamesToAdd) {
                            (_a = dayRef.classList).add.apply(_a, classNamesToAdd.split(' '));
                        }
                    }
                }
            });
        };
        var onMouseDownDay = function (ev) {
            var dayInfos = getDayInfosInRangeOfDay(day);
            var dayRefs = getRefsFromDayInfos(dayInfos);
            dayRefs.forEach(function (dayRef) {
                if (dayRef) {
                    dayRef.classList.add('ms-CalendarDay-pressedStyle');
                }
            });
        };
        var onMouseUpDay = function (ev) {
            var dayInfos = getDayInfosInRangeOfDay(day);
            var dayRefs = getRefsFromDayInfos(dayInfos);
            dayRefs.forEach(function (dayRef) {
                if (dayRef) {
                    dayRef.classList.remove('ms-CalendarDay-pressedStyle');
                }
            });
        };
        var onMouseOutDay = function (ev) {
            var dayInfos = getDayInfosInRangeOfDay(day);
            var dayRefs = getRefsFromDayInfos(dayInfos);
            dayRefs.forEach(function (dayRef, index) {
                var _a;
                if (dayRef) {
                    dayRef.classList.remove('ms-CalendarDay-hoverStyle');
                    dayRef.classList.remove('ms-CalendarDay-pressedStyle');
                    if (!dayInfos[index].isSelected &&
                        dateRangeType === date_time_utilities_1.DateRangeType.Day &&
                        daysToSelectInDayView &&
                        daysToSelectInDayView > 1) {
                        var classNamesToAdd = calculateRoundedStyles(classNames, false, false, index > 0, index < dayRefs.length - 1).trim();
                        if (classNamesToAdd) {
                            (_a = dayRef.classList).remove.apply(_a, classNamesToAdd.split(' '));
                        }
                    }
                }
            });
        };
        var onDayKeyDown = function (ev) {
            var _a;
            // eslint-disable-next-line deprecation/deprecation
            if (ev.which === utilities_1.KeyCodes.enter) {
                (_a = onSelectDate) === null || _a === void 0 ? void 0 : _a(day.originalDate);
            }
            else {
                navigateMonthEdge(ev, day.originalDate);
            }
        };
        var ariaLabel = dateTimeFormatter.formatMonthDayYear(day.originalDate, strings);
        if (day.isMarked) {
            ariaLabel = ariaLabel + ', ' + strings.dayMarkedAriaLabel;
        }
        return (React.createElement("td", { className: utilities_1.css(classNames.dayCell, weekCorners && cornerStyle, day.isSelected && classNames.daySelected, day.isSelected && 'ms-CalendarDay-daySelected', !day.isInBounds && classNames.dayOutsideBounds, !day.isInMonth && classNames.dayOutsideNavigatedMonth), ref: function (element) {
                var _a;
                (_a = customDayCellRef) === null || _a === void 0 ? void 0 : _a(element, day.originalDate, classNames);
                day.setRef(element);
            }, "aria-hidden": ariaHidden, onClick: day.isInBounds && !ariaHidden ? day.onSelected : undefined, onMouseOver: !ariaHidden ? onMouseOverDay : undefined, onMouseDown: !ariaHidden ? onMouseDownDay : undefined, onMouseUp: !ariaHidden ? onMouseUpDay : undefined, onMouseOut: !ariaHidden ? onMouseOutDay : undefined, role: "presentation" // the child <button> is the gridcell that our parent <tr> contains, so tell ARIA we are not
         },
            React.createElement("button", { key: day.key + 'button', "aria-hidden": ariaHidden, className: utilities_1.css(classNames.dayButton, day.isToday && classNames.dayIsToday, day.isToday && 'ms-CalendarDay-dayIsToday'), onKeyDown: !ariaHidden ? onDayKeyDown : undefined, "aria-label": ariaLabel, id: isNavigatedDate ? activeDescendantId : undefined, "aria-current": day.isSelected ? 'date' : undefined, "aria-selected": day.isInBounds ? day.isSelected : undefined, "data-is-focusable": !ariaHidden && (allFocusable || (day.isInBounds ? true : undefined)), ref: isNavigatedDate ? navigatedDayRef : undefined, disabled: !allFocusable && !day.isInBounds, "aria-disabled": !ariaHidden && !day.isInBounds, type: "button", role: "gridcell" // create grid structure
                , "aria-readonly": true, tabIndex: isNavigatedDate ? 0 : undefined },
                React.createElement("span", { "aria-hidden": "true" }, dateTimeFormatter.formatDay(day.originalDate)),
                day.isMarked && React.createElement("div", { "aria-hidden": "true", className: classNames.dayMarker }))));
    };
});
//# sourceMappingURL=CalendarGridDayCell.js.map                                                                                                                                                                                                                                                                                                                                                                                                                                               